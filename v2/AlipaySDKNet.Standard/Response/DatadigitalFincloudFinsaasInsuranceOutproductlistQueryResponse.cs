using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceOutproductlistQueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasInsuranceOutproductlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 外部产品列表
        /// </summary>
        [XmlArray("outer_product_items")]
        [XmlArrayItem("outer_product_v_o")]
        public List<OuterProductVO> OuterProductItems { get; set; }
    }
}
