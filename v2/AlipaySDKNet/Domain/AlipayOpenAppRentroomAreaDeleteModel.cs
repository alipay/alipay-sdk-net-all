using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppRentroomAreaDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppRentroomAreaDeleteModel : AopObject
    {
        /// <summary>
        /// 支付宝平台生成的小区ID列表
        /// </summary>
        [XmlArray("area_id_list")]
        [XmlArrayItem("string")]
        public List<string> AreaIdList { get; set; }

        /// <summary>
        /// 商户侧定义的小区编码列表
        /// </summary>
        [XmlArray("out_area_id_list")]
        [XmlArrayItem("string")]
        public List<string> OutAreaIdList { get; set; }
    }
}
