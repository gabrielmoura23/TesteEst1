﻿using System;
using System.Collections.Generic;
using IEL.Estagio.Domain.Interfaces.Repository;
using IEL.Estagio.Domain.Interfaces.Services;

namespace IEL.Estagio.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository; 

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public virtual TEntity GetById(Guid id)
        {
           return _repository.GetById(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public virtual void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public virtual TEntity GetByIdTipoInteiro(int id)
        {
            return _repository.GetByIdTipoInteiro(id);
        }
    }
}
