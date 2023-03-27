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
        /// 数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 商户所在行业:  goodsNormal（通用行业商品数据）  goodsLease（租赁行业商品数据）
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }
    }
}
