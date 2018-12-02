using AutoMapper;
using CDB.BLL.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDB.BLL.Implementation
{
    
    public class ModelMapHelper : IModelMapHelper
    {
        private readonly IMapper _mapper;

        public ModelMapHelper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TDestination Map<TDestination>(object source)
        {
            return _mapper.Map<TDestination>(source);
        }

        
        public void Map<TSource, TDestination>(object source, object destination)
        { 
            _mapper.Map<TSource, TDestination>((TSource)source, (TDestination)destination);
        }
    }
    
}