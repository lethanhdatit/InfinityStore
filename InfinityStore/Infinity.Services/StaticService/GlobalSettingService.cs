using Infinity.Common;
using Infinity.Data;
using Infinity.DTOs;
using Infinity.Repositories;
using Infinity.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Services
{
    public class GlobalSettingModel
    {
        public string WebHotline { get; set; }
        public string WebEmail { get; set; }
        public string WebAddress { get; set; }
        public string WebDevOrganization { get; set; }
        public string CopyrightYear { get; set; }
        public string FanpageFacebook { get; set; }
        public string FanpageTwitter { get; set; }
        public string YouTubeChannel { get; set; }
    }
    public class GlobalSettingService
    {
        private readonly InfinityStoreDBContext _context;
        private static GlobalSettingModel _Data = new GlobalSettingModel();
        public GlobalSettingService(InfinityStoreDBContext context)
        {
            _context = context;
            InitializeCommonData();
        }

        private void InitializeCommonData()
        {
            var data = _context.GlobalSettings.Where(x => x.Status == (byte)GlobalSettingStatus.Active);

            _Data.WebHotline = data?.FirstOrDefault(x => x.Name.ToLower() == "webhotline")?.Value;
            _Data.WebEmail = data?.FirstOrDefault(x => x.Name.ToLower() == "webemail")?.Value;
            _Data.WebAddress = data?.FirstOrDefault(x => x.Name.ToLower() == "webaddress")?.Value;
            _Data.WebDevOrganization = data?.FirstOrDefault(x => x.Name.ToLower() == "webdevorg")?.Value;
            _Data.CopyrightYear = data?.FirstOrDefault(x => x.Name.ToLower() == "copyrightyear")?.Value;
            _Data.FanpageFacebook = data?.FirstOrDefault(x => x.Name.ToLower() == "fanpagefacebook")?.Value;
            _Data.FanpageTwitter = data?.FirstOrDefault(x => x.Name.ToLower() == "fanpagetwitter")?.Value;
            _Data.YouTubeChannel = data?.FirstOrDefault(x => x.Name.ToLower() == "youtubechannel")?.Value;
        }
        public void FetchData()
        {
            InitializeCommonData();
        }
        public GlobalSettingModel Get()
        {
            if (_Data == null) InitializeCommonData();
            return _Data;
        }
    }
}
