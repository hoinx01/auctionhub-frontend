using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using AutoMapper.Configuration;

namespace Application.Web.Components
{
    public static class AuctionHubMapperInitiator
    {
        public static void Init()
        {
            var cfg = new MapperConfigurationExpression();
            cfg.CreateMissingTypeMaps = true;
            cfg.ForAllMaps((map, exp) => {
                foreach (var unmappedPropertyName in map.GetUnmappedPropertyNames())
                {
                    exp.ForMember(unmappedPropertyName, opt => opt.Ignore());
                }
            });
            RegisterMapping(cfg);
            Mapper.Initialize(cfg);
            
        }
        /*
         * Cần custom mapping nào thì viết ở đây
         */
        public static void RegisterMapping(IMapperConfigurationExpression cfg)
        {
            //cfg.CreateMap<MdPost, EsPost>().ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}
