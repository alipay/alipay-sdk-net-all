using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateMpcpromoSceneAddResponse.
    /// </summary>
    public class TechriskInnovateMpcpromoSceneAddResponse : AopResponse
    {
        /// <summary>
        /// 非法数据列表
        /// </summary>
        [XmlArray("illegal_goods_list")]
        [XmlArrayItem("string")]
        public List<string> IllegalGoodsList { get; set; }
    }
}
