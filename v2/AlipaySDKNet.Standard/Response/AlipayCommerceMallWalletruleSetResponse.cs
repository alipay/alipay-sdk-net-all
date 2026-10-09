using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMallWalletruleSetResponse.
    /// </summary>
    public class AlipayCommerceMallWalletruleSetResponse : AopResponse
    {
        /// <summary>
        /// 操作类型为query时返回，此钱包模板下配置的核销数字化门店列表；操作类型为add时返回，此次操作下配置的已生效的核销数字化门店列表；
        /// </summary>
        [XmlArray("digital_shop_id_list")]
        [XmlArrayItem("string")]
        public List<string> DigitalShopIdList { get; set; }

        /// <summary>
        /// 操作类型为query时返回，此钱包模板下配置的待生效核销数字化门店列表；操作类型为add时返回，此次操作下配置的待生效的核销数字化门店列表； 待生效数据：门店下暂无N设备数据
        /// </summary>
        [XmlArray("pending_shop_id_list")]
        [XmlArrayItem("string")]
        public List<string> PendingShopIdList { get; set; }

        /// <summary>
        /// 本次操作的钱包模板id
        /// </summary>
        [XmlElement("wallet_template_id")]
        public string WalletTemplateId { get; set; }
    }
}
