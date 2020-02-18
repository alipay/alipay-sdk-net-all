using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInformationUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalInformationUploadResponse : AopResponse
    {
        /// <summary>
        /// 报备成功时间
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 根据各地人社局返回为准，与入参数request_content对应的业务响应数据。
        /// </summary>
        [XmlElement("response_content")]
        public string ResponseContent { get; set; }
    }
}
