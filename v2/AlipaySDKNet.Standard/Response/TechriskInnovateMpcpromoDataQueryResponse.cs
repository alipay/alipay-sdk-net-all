using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// TechriskInnovateMpcpromoDataQueryResponse.
    /// </summary>
    public class TechriskInnovateMpcpromoDataQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品数据列表
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("mpcpromo_goods_list")]
        public List<MpcpromoGoodsList> GoodsList { get; set; }
    }
}
