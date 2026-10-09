using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAddressDefaultaddressQueryResponse.
    /// </summary>
    public class AlipayUserAddressDefaultaddressQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户默认收货地址。取值逻辑：1，如果用户有设置默认地址，则返回该地址；2，如果用户有添加地址但没设置默认地址，取最近修改的地址；3，如果用户没有地址，该字段没有值。
        /// </summary>
        [XmlElement("default_address")]
        public DefaultDeliverAddress DefaultAddress { get; set; }
    }
}
