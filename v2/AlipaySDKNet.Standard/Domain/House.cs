using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// House Data Structure.
    /// </summary>
    [Serializable]
    public class House : AopObject
    {
        /// <summary>
        /// 房屋所在区县编号
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 建成年份
        /// </summary>
        [XmlElement("built_year")]
        public string BuiltYear { get; set; }

        /// <summary>
        /// 房屋产权人列表
        /// </summary>
        [XmlArray("house_owners")]
        [XmlArrayItem("house_owner")]
        public List<HouseOwner> HouseOwners { get; set; }

        /// <summary>
        /// 不动产单元号(可能多个)
        /// </summary>
        [XmlArray("house_unit_codes")]
        [XmlArrayItem("string")]
        public List<string> HouseUnitCodes { get; set; }

        /// <summary>
        /// 房屋所在层数
        /// </summary>
        [XmlElement("its_floor")]
        public string ItsFloor { get; set; }

        /// <summary>
        /// 土地证号
        /// </summary>
        [XmlElement("land_cert_no")]
        public string LandCertNo { get; set; }

        /// <summary>
        /// 房屋坐落地址
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 是否有抵押。enum (Y, N)
        /// </summary>
        [XmlElement("mortgaged")]
        public string Mortgaged { get; set; }

        /// <summary>
        /// 房产共有情况。 enum (INDIVIDUALLY-单独所有, SHARE_COOWNER-共同共有, SEVERAL_COOWNER-按份共有, OTHER_COOWNER-其他共有, UNKNOWN--)
        /// </summary>
        [XmlElement("owner_ship_status")]
        public string OwnerShipStatus { get; set; }

        /// <summary>
        /// 房屋建筑面积
        /// </summary>
        [XmlElement("structure_area")]
        public string StructureArea { get; set; }

        /// <summary>
        /// 房屋建筑面积单位。 enum (SQUARE_METER-平方米, MU-亩, SQUARE_CENTIMETER-平方厘米, HECTARE-公顷)
        /// </summary>
        [XmlElement("structure_area_unit")]
        public string StructureAreaUnit { get; set; }

        /// <summary>
        /// 总层数
        /// </summary>
        [XmlElement("total_floor")]
        public string TotalFloor { get; set; }
    }
}
