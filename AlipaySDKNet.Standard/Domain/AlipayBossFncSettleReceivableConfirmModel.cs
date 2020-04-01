using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncSettleReceivableConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncSettleReceivableConfirmModel : AopObject
    {
        /// <summary>
        /// 批量应收确认请求列表
        /// </summary>
        [XmlArray("receivable_confirm_order_list")]
        [XmlArrayItem("receivable_confirm_order")]
        public List<ReceivableConfirmOrder> ReceivableConfirmOrderList { get; set; }
    }
}
