﻿using System;
using System.Collections.Generic;
using EZNEW.Cache;

namespace AppConfig.Cache
{
    public static class CacheConfig
    {
        public static void Configure()
        {
            //配置缓存服务器
            CacheManager.Configuration.ConfigureCacheServer(option =>
            {
                return new List<CacheServer>()
                {
                    new CacheServer("inmemory",CacheServerType.InMemory)
                };
            });
        }
    }
}
