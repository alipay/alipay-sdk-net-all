using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainFactoringSelleradmitQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainFactoringSelleradmitQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否已提交加白申请
        /// </summary>
        [XmlElement("exsit")]
        public string Exsit { get; set; }

        /// <summary>
        /// 门店是否需要签约  true:需要签约 false：不需要签约
        /// </summary>
        [XmlElement("need_sign_ar")]
        public bool NeedSignAr { get; set; }

        /// <summary>
        /// 不准入原因代码
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 门店不准入原因
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 门店是否为不准入
        /// </summary>
        [XmlElement("refused")]
        public string Refused { get; set; }

        /// <summary>
        /// 门店网商银行卡号
        /// </summary>
        [XmlArray("seller_mybank_card_no_list")]
        [XmlArrayItem("string")]
        public List<string> SellerMybankCardNoList { get; set; }

        /// <summary>
        /// 是否加白成功
        /// </summary>
        [XmlElement("white")]
        public string White { get; set; }
    }
}
