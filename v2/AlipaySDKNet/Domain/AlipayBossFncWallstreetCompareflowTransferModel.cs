using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncWallstreetCompareflowTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncWallstreetCompareflowTransferModel : AopObject
    {
        /// <summary>
        /// 对比方法名 不唯一 获取对比方法 无枚举 对应方法名称
        /// </summary>
        [XmlElement("compare_method_name")]
        public string CompareMethodName { get; set; }

        /// <summary>
        /// 对比方法参数类型列表
        /// </summary>
        [XmlArray("compare_method_param_tp")]
        [XmlArrayItem("string")]
        public List<string> CompareMethodParamTp { get; set; }

        /// <summary>
        /// 对比服务名称 非唯一 用于查询对比服务 无枚举值 全限定类名
        /// </summary>
        [XmlElement("compare_service")]
        public string CompareService { get; set; }

        /// <summary>
        /// 参数列表
        /// </summary>
        [XmlElement("parameter_map")]
        public string ParameterMap { get; set; }

        /// <summary>
        /// VPC机房结果
        /// </summary>
        [XmlElement("vpc_result")]
        public string VpcResult { get; set; }
    }
}
