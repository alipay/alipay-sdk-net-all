using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkloanDataQueryResponse.
    /// </summary>
    public class ZhimaCreditEpCreditlinkloanDataQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询到的的数据信息，是JSON结构，其key值和入参中的collect_data_type对应，例如 {"ELEME_RISK_ADMISSION":{"passStatus":1,"epList":[{"epName":"A","epCertNo":"001A","operatorName":"张三"},{"epName":"B","epCertNo":"001B","operatorName":"张三"}]}}
        /// </summary>
        [XmlElement("collect_data_content")]
        public string CollectDataContent { get; set; }

        /// <summary>
        /// 商户单号，正常调用返回的数据和入参中的商户单号保持一致
        /// </summary>
        [XmlElement("merchant_biz_no")]
        public string MerchantBizNo { get; set; }
    }
}
