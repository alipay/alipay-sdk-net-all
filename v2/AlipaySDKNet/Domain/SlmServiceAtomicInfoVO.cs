using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SlmServiceAtomicInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class SlmServiceAtomicInfoVO : AopObject
    {
        /// <summary>
        /// 操作动作或业务分类，例如：查找、搜索、我的小程序等
        /// </summary>
        [XmlElement("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 动作描述
        /// </summary>
        [XmlElement("operate_desc")]
        public string OperateDesc { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [XmlElement("operator")]
        public Operator Operator { get; set; }

        /// <summary>
        /// 前端框架service和atomic接口信息
        /// </summary>
        [XmlElement("slm_service_atomic_info_list")]
        public SlmMethodInfo SlmServiceAtomicInfoList { get; set; }

        /// <summary>
        /// 操作功能类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
