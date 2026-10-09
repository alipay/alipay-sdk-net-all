using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthJobdataAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerJobworthJobdataAddModel : AopObject
    {
        /// <summary>
        /// 身份证证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 0:身份证1:护照2:台湾同胞回乡证3:港澳居民往来内地通行证4:台湾居民通行证5:港澳居民通行证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 关联key，受理台返回
        /// </summary>
        [XmlElement("conn_key")]
        public string ConnKey { get; set; }

        /// <summary>
        /// 回传信息
        /// </summary>
        [XmlArray("job_data_list")]
        [XmlArrayItem("job_worth_jobdata")]
        public List<JobWorthJobdata> JobDataList { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户中文名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
