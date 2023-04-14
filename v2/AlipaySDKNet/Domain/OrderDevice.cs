using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderDevice Data Structure.
    /// </summary>
    [Serializable]
    public class OrderDevice : AopObject
    {
        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 实际安装照片：最多5张，英文逗号分隔(,) ，图片格式必须（bmp,jpg,png,gif,image）
        /// </summary>
        [XmlElement("install_actual_photo")]
        public string InstallActualPhoto { get; set; }

        /// <summary>
        /// 安装方式：挂壁安装（WALL_MOUNTING），底座支架安装(RACK_MOUNTING)
        /// </summary>
        [XmlElement("install_mode")]
        public string InstallMode { get; set; }

        /// <summary>
        /// 铺屏现场照片: 最多5张，英文逗号分隔(,) ，图片格式必须（bmp,jpg,png,gif,image）
        /// </summary>
        [XmlElement("install_scene_photo")]
        public string InstallScenePhoto { get; set; }

        /// <summary>
        /// 是否安装路由器
        /// </summary>
        [XmlElement("is_install_router")]
        public bool IsInstallRouter { get; set; }

        /// <summary>
        /// 设备屏幕尺寸:INCH_24 (24英寸)、INCH_32(32英寸)、INCH_64（64英寸）
        /// </summary>
        [XmlElement("screen_size")]
        public string ScreenSize { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        [XmlElement("supplier_sn")]
        public string SupplierSn { get; set; }
    }
}
