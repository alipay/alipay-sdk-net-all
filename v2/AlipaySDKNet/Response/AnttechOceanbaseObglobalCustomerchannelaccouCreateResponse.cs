using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalCustomerchannelaccouCreateResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalCustomerchannelaccouCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务错误码
        /// </summary>
        [XmlElement("biz_error_code")]
        public string BizErrorCode { get; set; }

        /// <summary>
        /// 业务错误信息
        /// </summary>
        [XmlElement("biz_error_msg")]
        public string BizErrorMsg { get; set; }

        /// <summary>
        /// 业务是否成功
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 创建客户关联渠道账号返回结果
        /// </summary>
        [XmlElement("result")]
        public FxiaokeCreateCustomerChannelAccountResponse Result { get; set; }
    }
}
