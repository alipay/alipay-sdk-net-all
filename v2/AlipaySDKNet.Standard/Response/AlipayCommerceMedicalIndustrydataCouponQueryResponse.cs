using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataCouponQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataCouponQueryResponse : AopResponse
    {
        /// <summary>
        /// 该参数是返回查询得到用户可用营销优惠卷信息，数组为空则表示没有查询到
        /// </summary>
        [XmlArray("vouchers")]
        [XmlArrayItem("vouchers")]
        public List<Vouchers> Vouchers { get; set; }
    }
}
