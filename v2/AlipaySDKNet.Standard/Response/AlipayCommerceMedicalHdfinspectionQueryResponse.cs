using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfinspectionQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfinspectionQueryResponse : AopResponse
    {
        /// <summary>
        /// hdf的履约单号
        /// </summary>
        [XmlElement("hdf_check_no")]
        public string HdfCheckNo { get; set; }

        /// <summary>
        /// hdf的用户年龄
        /// </summary>
        [XmlElement("hdf_user_age")]
        public string HdfUserAge { get; set; }

        /// <summary>
        /// hdf的用户号码
        /// </summary>
        [XmlElement("hdf_user_mb")]
        public string HdfUserMb { get; set; }

        /// <summary>
        /// hdf的用户名
        /// </summary>
        [XmlElement("hdf_user_name")]
        public string HdfUserName { get; set; }

        /// <summary>
        /// hdf的用户编码
        /// </summary>
        [XmlElement("hdf_user_no")]
        public string HdfUserNo { get; set; }

        /// <summary>
        /// 用户性别
        /// </summary>
        [XmlElement("hdf_user_sex")]
        public string HdfUserSex { get; set; }

        /// <summary>
        /// 履约单下的标准项目
        /// </summary>
        [XmlElement("inspection_item_sku_ids")]
        public string InspectionItemSkuIds { get; set; }

        /// <summary>
        /// 履约单下的组合项目
        /// </summary>
        [XmlElement("inspection_package_sku_ids")]
        public string InspectionPackageSkuIds { get; set; }
    }
}
