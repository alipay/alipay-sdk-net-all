using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItempriceByisvitemidModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalItempriceByisvitemidModifyResponse : AopResponse
    {
        /// <summary>
        /// 失败信息
        /// </summary>
        [XmlArray("fail_list")]
        [XmlArrayItem("isv_item_id_item_price_fail_d_t_o")]
        public List<IsvItemIdItemPriceFailDTO> FailList { get; set; }

        /// <summary>
        /// 成功信息
        /// </summary>
        [XmlArray("succ_list")]
        [XmlArrayItem("isv_item_id_item_price_success_d_t_o")]
        public List<IsvItemIdItemPriceSuccessDTO> SuccList { get; set; }
    }
}
