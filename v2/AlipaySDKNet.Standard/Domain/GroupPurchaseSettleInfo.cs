using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupPurchaseSettleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GroupPurchaseSettleInfo : AopObject
    {
        /// <summary>
        /// 结算到户的账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 结算银行卡信息
        /// </summary>
        [XmlElement("bank_card")]
        public GroupPurchaseBankCard BankCard { get; set; }

        /// <summary>
        /// 资金证明图片,使用openApi接口ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。文件最小为 5KB，最大为5M，图片格式必须为：png、jpg、jpeg。
        /// </summary>
        [XmlArray("fund_proofs_url")]
        [XmlArrayItem("string")]
        public List<string> FundProofsUrl { get; set; }

        /// <summary>
        /// 资金关系类型
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 法人证照图片正面，使用openApi接口ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。文件最小为 5KB，最大为5M，图片格式必须为：png、jpg、jpeg。
        /// </summary>
        [XmlElement("legal_cert_image")]
        public string LegalCertImage { get; set; }

        /// <summary>
        /// 法人证照图片反面，使用openApi接口ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。文件最小为 5KB，最大为5M，图片格式必须为：png、jpg、jpeg。
        /// </summary>
        [XmlElement("legal_cert_image_back")]
        public string LegalCertImageBack { get; set; }

        /// <summary>
        /// 组织证照图片，使用openApi接口ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。文件最小为 5KB，最大为5M，图片格式必须为：png、jpg、jpeg。
        /// </summary>
        [XmlElement("org_cert_image")]
        public string OrgCertImage { get; set; }

        /// <summary>
        /// 结算类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
