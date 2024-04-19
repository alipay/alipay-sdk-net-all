using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceUserquerybyuidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceUserquerybyuidQueryModel : AopObject
    {
        /// <summary>
        /// 客服小二的2088id
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 是否查询用户关联账户信息
        /// </summary>
        [XmlElement("query_ref_account")]
        public bool QueryRefAccount { get; set; }

        /// <summary>
        /// 是否查询用户角色信息
        /// </summary>
        [XmlElement("query_role")]
        public bool QueryRole { get; set; }

        /// <summary>
        /// 是否查询服务
        /// </summary>
        [XmlElement("query_serve")]
        public bool QueryServe { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
