using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMallWalletruleSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMallWalletruleSetModel : AopObject
    {
        /// <summary>
        /// 此商圈钱包模板下，需设置的核销数字化门店列表；当操作类型type为query时，可不填；建议单次小于100，数量过大可能存在超时
        /// </summary>
        [XmlArray("digital_shop_id_list")]
        [XmlArrayItem("string")]
        public List<string> DigitalShopIdList { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 核销数字化门店列表，操作类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 钱包模板编号
        /// </summary>
        [XmlElement("wallet_template_id")]
        public string WalletTemplateId { get; set; }

        /// <summary>
        /// 创建钱包模板pid，创建钱包pid与商户调用主体pid不一致时必传
        /// </summary>
        [XmlElement("wallet_template_pid")]
        public string WalletTemplatePid { get; set; }
    }
}
