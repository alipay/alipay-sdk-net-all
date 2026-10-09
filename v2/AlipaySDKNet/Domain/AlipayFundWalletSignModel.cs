using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletSignModel : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("identity_name")]
        public string IdentityName { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("identity_no")]
        public string IdentityNo { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
