using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemstockByisvitemidModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemstockByisvitemidModifyResponse : AopResponse
    {
        /// <summary>
        /// 失败记录
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("isv_item_id_item_stock_fail_d_t_o")]
        public List<IsvItemIdItemStockFailDTO> FailList { get; set; }

        /// <summary>
        /// 成功记录
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("isv_item_id_item_stock_success_d_t_o")]
        public List<IsvItemIdItemStockSuccessDTO> SuccList { get; set; }
    }
}
