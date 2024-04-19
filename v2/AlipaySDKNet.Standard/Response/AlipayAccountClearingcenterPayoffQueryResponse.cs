using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAccountClearingcenterPayoffQueryResponse.
    /// </summary>
    public class AlipayAccountClearingcenterPayoffQueryResponse : AopResponse
    {
        /// <summary>
        /// 待解付登记薄列表
        /// </summary>
        [XmlArray("pay_off_order_list")]
        [XmlArrayItem("pay_off_order_v_o")]
        public List<PayOffOrderVO> PayOffOrderList { get; set; }

        /// <summary>
        /// EXECUTE_SUCCESS UNKNOWN_EXCEPTION DATABASE_EXCEPTION
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 处理成功 未知异常 数据库异常
        /// </summary>
        [XmlElement("result_description")]
        public string ResultDescription { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
