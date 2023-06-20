using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using InstagramClone.Models;

namespace InstagramClone.ViewModels
{
    public class MainPageViewModel
    {
        private IList<TopStory> _topStrories;
        public IList<TopStory> TopStories
        {
            get
            {
                return new List<TopStory>
                {
                    new TopStory
                    {
                         Id=1,
                         ImagePath="https://picsum.photos/id/11/2500/1667",
                         Text = "Trees"
                    },
                    new TopStory
                    {
                        Id=2,
                        ImagePath="https://picsum.photos/id/12/2500/1667",
                        Text = "Galaxy"
                    },
                    new TopStory
                    {
                        Id=3,
                        ImagePath="https://picsum.photos/id/13/2500/1667",
                        Text = "Mountains"
                    },
                    new TopStory
                    {
                        Id=4,
                        ImagePath="https://picsum.photos/id/14/2500/1667",
                        Text = "Flower"
                    },
                    new TopStory
                    {
                         Id=5,
                         ImagePath="https://picsum.photos/id/15/2500/1667",
                         Text = "Love"
                    },
                    new TopStory
                    {
                         Id=6,
                         ImagePath="https://picsum.photos/id/16/2500/1667",
                         Text = "MySelf"
                    },

                };
            }
            set
            {
                _topStrories = value;
            }
        }

        private UserProfile _userProfile;
        public UserProfile UserProfile
        {
            get
            {
                return new UserProfile
                {
                    UserName = "username",
                    FrontName = "Front Name",
                    Bio = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Link = "www.username.com/social"
                };
            }
        }

        private IList<Post> _list;
        public IList<Post> List
        {
            get
            {
                if (_list == null)
                    _list = new ObservableCollection<Post>();
                return _list;
            }
            set
            {
                _list = value;
            }
        }

        void Bind()
        {
            List.Clear();

            for (int i = 0; i < 10; i++)
            {
                List.Add(new Post
                {
                    Id = i,
                    ImagePath = $"https://picsum.photos/id/{10 + i}/2500/1667",
                    Text = $"{i}st nature post"
                });
            }

            TopStories.Clear();

            for (int i = 0; i < 10; i++)
            {
                TopStories.Add(new TopStory
                {
                    Id = i,
                    ImagePath = $"https://picsum.photos/id/{10 + i}/2500/1667",
                    Text = $"{i}st nature post"
                });
            }
        }

        //public ICommand OnSelectedCommand => new Command((o) =>
        //{
        //    if (o != null && o is Post item)
        //    {
        //        List.Remove(item);
        //    }
        //});

        public MainPageViewModel()
        {
            Bind();
        }
    }
}

