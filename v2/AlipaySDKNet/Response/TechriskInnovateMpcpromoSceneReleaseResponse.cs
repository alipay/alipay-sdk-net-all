using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateMpcpromoSceneReleaseResponse.
    /// </summary>
    public class TechriskInnovateMpcpromoSceneReleaseResponse : AopResponse
    {
        /// <summary>
        /// 非法商品id列表
        /// </summary>
        [XmlArray("illegal_goods_list")]
        [XmlArrayItem("string")]
        public List<string> IllegalGoodsList { get; set; }
    }
}
