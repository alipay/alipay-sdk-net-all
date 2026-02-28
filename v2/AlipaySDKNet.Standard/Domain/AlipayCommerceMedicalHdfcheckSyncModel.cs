using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfcheckSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfcheckSyncModel : AopObject
    {
        /// <summary>
        /// 双方定义
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 已退款、已取消时有
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 已退款、已取消时有
        /// </summary>
        [XmlElement("cancel_time")]
        public string CancelTime { get; set; }

        /// <summary>
        /// hdf申请单号
        /// </summary>
        [XmlElement("hdf_apply_no")]
        public string HdfApplyNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_info_list")]
        [XmlArrayItem("sync_status_item_info")]
        public List<SyncStatusItemInfo> ItemInfoList { get; set; }

        /// <summary>
        /// 订单总金额，单位：元
        /// </summary>
        [XmlElement("order_price")]
        public string OrderPrice { get; set; }

        /// <summary>
        /// 履约方单号
        /// </summary>
        [XmlElement("union_apply_no")]
        public string UnionApplyNo { get; set; }

        /// <summary>
        /// 履约方支付状态，1:待支付 2:已支付 3:已退款 4:已取消
        /// </summary>
        [XmlElement("union_apply_pay_status")]
        public long UnionApplyPayStatus { get; set; }
    }
}
