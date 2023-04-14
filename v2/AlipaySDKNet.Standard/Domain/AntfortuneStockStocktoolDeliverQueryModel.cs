using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockStocktoolDeliverQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockStocktoolDeliverQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 查询用户是否能在某个展位下透出，支持批量查询
        /// </summary>
        [XmlArray("position_list")]
        [XmlArrayItem("string")]
        public List<string> PositionList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
