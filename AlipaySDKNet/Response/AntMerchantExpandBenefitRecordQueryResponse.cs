using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandBenefitRecordQueryResponse.
    /// </summary>
    public class AntMerchantExpandBenefitRecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [XmlElement("biz_ext")]
        public string BizExt { get; set; }

        /// <summary>
        /// 返回的数据,JSON格式
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 查询失败时，返回的错误信息
        /// </summary>
        [XmlElement("detail_msg")]
        public string DetailMsg { get; set; }

        /// <summary>
        /// 查询失败的错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }
    }
}
