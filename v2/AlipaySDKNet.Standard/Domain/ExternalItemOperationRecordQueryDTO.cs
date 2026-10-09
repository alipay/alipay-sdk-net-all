using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalItemOperationRecordQueryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalItemOperationRecordQueryDTO : AopObject
    {
        /// <summary>
        /// 支付宝的服务产品编号
        /// </summary>
        [XmlElement("ant_ser_prod_no")]
        public string AntSerProdNo { get; set; }

        /// <summary>
        /// 扩展字段。注意：本字段是一个String类型的JSON
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 触发时间
        /// </summary>
        [XmlElement("init_time")]
        public string InitTime { get; set; }

        /// <summary>
        /// 机构商品编码
        /// </summary>
        [XmlElement("merchant_item_code")]
        public string MerchantItemCode { get; set; }

        /// <summary>
        /// 药品操作记录编号 (唯一标识当前药品操作记录)
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 药品操作类型。 MAJOR 主要信息; EXT 扩展信息; UP 上架; DOWN 下架商品
        /// </summary>
        [XmlElement("refresh_type")]
        public string RefreshType { get; set; }

        /// <summary>
        /// 状态。 PROCESSING  执行中， SUCCESS 成功， FAIL 执行失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
