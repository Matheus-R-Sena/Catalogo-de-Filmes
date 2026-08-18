using B.A.Application.Helpers;
using B.A.Application.Interfaces;
using B.A.Domain.Interfaces;
using B.A.Domain.Models;
using B.A.Shared.Enums;
using System;

namespace B.C.Application.UseCases.Acoes
{
    public class CriarAcaoUseCase : IInteractor<CriarAcaoRequest, Result<CriarAcaoResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CriarAcaoUseCase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Result<CriarAcaoResponse> Execute(CriarAcaoRequest request)
        {
            try
            {
                Acao acao = new Acao
                {
                    Action = request.Action,
                    Controller = request.Controller,
                    EventoEnum = request.EventoEnum,
                    Pai = request.Pai,
                    Prioridade = request.Prioridade,
                    PrioridadeInterna = request.PrioridadeInterna,
                    URL = request.URL,
                    VisivelNoMenu = request.VisivelNoMenu.ConvertToEnum(),
                    Sistema = request.Sistema,
                    UrlExterna = request.UrlExterna.ConvertToEnum()
                };

                _unitOfWork.AcaoRepository.SaveOrUpdate(acao);

                foreach (AcaoPerfil acaoPerfil in request.EscolhaPerfis)
                {
                    if (acaoPerfil.Check)
                    {
                        Perfil perfil = _unitOfWork.PerfilRepository.Get(acaoPerfil.PerfilId);
                        perfil.Acoes.Add(acao);
                        _unitOfWork.PerfilRepository.SaveOrUpdate(perfil);
                    }
                }
                _unitOfWork.Commit();

                return Result<CriarAcaoResponse>.Success(new CriarAcaoResponse(acao), "Ação criada com sucesso!");
            }
            catch (Exception e)
            {
                _unitOfWork.Rollback();
                return Result<CriarAcaoResponse>.Failure("Não foi possível criar a ação!", e);
            }
        }
    }
}
