using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalOrderDetailQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalOrderDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("items_v_o")]
        public List<ItemsVO> Items { get; set; }

        /// <summary>
        /// 医保报销信息
        /// </summary>
        [XmlElement("medicare")]
        public MedicareInfoVO Medicare { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlElement("order")]
        public OrderInfoVO Order { get; set; }

        /// <summary>
        /// 支付信息
        /// </summary>
        [XmlElement("payment")]
        public PaymentVO Payment { get; set; }

        /// <summary>
        /// 商户店铺信息
        /// </summary>
        [XmlElement("store")]
        public StoreVO Store { get; set; }

        /// <summary>
        /// 收货人信息
        /// </summary>
        [XmlElement("user")]
        public UserSimpleVO User { get; set; }
    }
}
