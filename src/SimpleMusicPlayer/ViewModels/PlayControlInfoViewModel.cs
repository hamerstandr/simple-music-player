﻿using ReactiveUI;

namespace MusicPlayer.ViewModels
{
    public class PlayControlInfoViewModel : ReactiveObject
    {
        public PlayControlInfoViewModel(MainViewModel mainViewModel)
        {
            this.PlayControlViewModel = new PlayControlViewModel(mainViewModel);
        }

        public PlayControlViewModel PlayControlViewModel { get; private set; }
    }
}
