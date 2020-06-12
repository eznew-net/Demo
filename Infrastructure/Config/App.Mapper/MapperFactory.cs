using System;
using AutoMapper;
using EZNEW.ModuleConfig.Sys;

namespace App.Mapper
{
    public static class MapperFactory
    {
        public static EZNEW.Mapper.IMapper CreateMapper()
        {
            Action<IMapperConfigurationExpression> configuration = ObjectMapConfig;
            ModuleConfig(ref configuration);
            var autoMapper = new AutoMapMapper();
            autoMapper.Register(configuration);
            EZNEW.Mapper.ObjectMapper.Current = autoMapper;
            return autoMapper;
        }

        /// <summary>
        /// ����ת��ӳ������
        /// </summary>
        /// <param name="expression"></param>
        static void ObjectMapConfig(IMapperConfigurationExpression expression)
        {
            //TODO
        }

        /// <summary>
        /// ����ģ������
        /// </summary>
        /// <param name="configuration"></param>
        static void ModuleConfig(ref Action<IMapperConfigurationExpression> configuration)
        {
            #region Sys

            SysModuleConfig.Init(ref configuration);

            #endregion
        }
    }
}
