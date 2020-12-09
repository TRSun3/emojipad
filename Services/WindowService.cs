﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronNET.API;
using ElectronNET.API.Entities;
using Microsoft.Extensions.Configuration;

namespace emojipad.Services
{
    public class WindowService
    {
        private BrowserWindow _mainWindow;
        private readonly IConfiguration _configuration;

        public WindowService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnLoad()
        {
            Task.Run(async () =>
            {
                _mainWindow = await Electron.WindowManager.CreateWindowAsync(new BrowserWindowOptions()
                {
                    Width = 450,
                    Height = 400,
                    Resizable = false,
                    AlwaysOnTop = true,
                    Title = "EmojiPad",
                    Show = Convert.ToBoolean(_configuration["ems:show-on-start"]),
                    Frame = false
                });
            });
        }

        public void Show()
        {
            
        }
    }
}
