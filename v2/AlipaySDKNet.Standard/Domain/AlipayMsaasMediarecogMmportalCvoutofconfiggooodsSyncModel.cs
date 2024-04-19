using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmportalCvoutofconfiggooodsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmportalCvoutofconfiggooodsSyncModel : AopObject
    {
        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 配置外商品数组
        /// </summary>
        [XmlArray("out_of_config_goods")]
        [XmlArrayItem("out_of_config_goods_result")]
        public List<OutOfConfigGoodsResult> OutOfConfigGoods { get; set; }

        /// <summary>
        /// 交易id
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
