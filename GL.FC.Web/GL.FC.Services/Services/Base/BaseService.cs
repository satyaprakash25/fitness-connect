using AutoMapper;
using GL.FC.Data;
using GL.FC.Data.Database;
using GL.FC.Shared;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GL.FC.Services
{
    public class BaseService<TModel, TEntity> : IBaseServices<TModel>
        where TModel : ModelBase
        where TEntity : BaseEntity
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;
        public BaseService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public TModel Add(TModel item)
        {
            return _mapper.Map<TModel>( _repository.Add(_mapper.Map<TEntity>(item)));
        }


        public IList<TModel> GetAll(string resolvedPropertyNames)
        {
            return _mapper.Map<IList<TModel>>(_repository.GetAll(resolvedPropertyNames));
        }


        public TModel GetById(long Id, string resolvedPropertyNames)
        {
            return _mapper.Map<TModel>(_repository.FirstOrDefault(a => a.Id == Id, resolvedPropertyNames));
        }

        public bool Remove(long id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(params TModel[] items)
        {
            throw new NotImplementedException();
        }

        public bool Update(params TModel[] items)
        {
            return _repository.Update(_mapper.Map<TEntity[]>(items));
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

    }
}
