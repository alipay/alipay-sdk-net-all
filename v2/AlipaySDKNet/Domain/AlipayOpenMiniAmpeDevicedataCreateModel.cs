using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeDevicedataCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeDevicedataCreateModel : AopObject
    {
        /// <summary>
        /// {navigationDestination:{longitude:"",latitude:""},navigationHome:{longitude:"",latitude:""},navigationCompany:{longitude:"",latitude:""},realTimeLocation:{longitude:"",latitude:""},deviceStateModel:{state:"",stateValue:"",stateValueType:""},controlActionList:[""],expectSceneCodes:[""]} 设备信息，jsonString格式，与ampe一致
        /// </summary>
        [XmlElement("device_data")]
        public string DeviceData { get; set; }

        /// <summary>
        /// 设备标识
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备产品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 通过ampe获取的用户标识
        /// </summary>
        [XmlElement("user_key")]
        public string UserKey { get; set; }

        /// <summary>
        /// 从ampe获取的用户路由标识
        /// </summary>
        [XmlElement("user_route")]
        public string UserRoute { get; set; }
    }
}
