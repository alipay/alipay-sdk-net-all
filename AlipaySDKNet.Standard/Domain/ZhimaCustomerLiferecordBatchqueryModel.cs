using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerLiferecordBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerLiferecordBatchqueryModel : AopObject
    {
        /// <summary>
        /// 支付宝userId的映射字段
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 根据外部业务号进行批量查询
        /// </summary>
        [XmlArray("out_biz_nos")]
        [XmlArrayItem("string")]
        public List<string> OutBizNos { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
