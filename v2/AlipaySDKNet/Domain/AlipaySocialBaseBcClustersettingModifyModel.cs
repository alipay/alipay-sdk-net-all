using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseBcClustersettingModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseBcClustersettingModifyModel : AopObject
    {
        /// <summary>
        /// 客户群分组id，此id唯一，分组下会管理一系列的客户群
        /// </summary>
        [XmlElement("cluster_id")]
        public string ClusterId { get; set; }

        /// <summary>
        /// 群公告
        /// </summary>
        [XmlElement("notice")]
        public string Notice { get; set; }

        /// <summary>
        /// 操作的商家标识id，可选，默认是应用app下的pid；如果填写第三方商家标识id，需要保证app下的pid是该商家的管理员
        /// </summary>
        [XmlElement("operate_business_id")]
        public string OperateBusinessId { get; set; }

        /// <summary>
        /// 客户群业务租户id，比如生态商家此id为7，b站开通商户为18
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 入群欢迎语
        /// </summary>
        [XmlElement("welcome_msg")]
        public string WelcomeMsg { get; set; }
    }
}
