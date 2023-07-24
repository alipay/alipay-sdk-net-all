using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateMpcpromoDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateMpcpromoDataSyncModel : AopObject
    {
        /// <summary>
        /// 商品数据的列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("mpcpromo_goods_list")]
        public List<MpcpromoGoodsList> DataList { get; set; }

        /// <summary>
        /// 数据类型 : USER（用户数据）、ITEM（商品数据）
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 行业类别:   goodsLease（常规/租赁 商品数据）
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }
    }
}
