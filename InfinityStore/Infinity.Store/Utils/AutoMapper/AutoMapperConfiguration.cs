using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infinity.Store
{
    public static class AutoMapperConfiguration
    {
        [Obsolete]
        public static void Config()
        {
            Mapper.Initialize(cfg => {
                cfg.AddProfile(new DtoEntityCommonMapper());
            });
        }
    }
}
