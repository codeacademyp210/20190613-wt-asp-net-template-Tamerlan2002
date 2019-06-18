using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public static class StaticLists
    {  
        public static List<Slider>  sliders = new List<Slider>()
        {
            new Slider
            {
                SliderId = 1,
                Photo = "slide_01.jpg",
                UpperCapt = "work hard",
                BottomCapt = "Dream Big",
                ButtonTitle = "Get Started"
            },
            new Slider
            {
                SliderId = 1,
                Photo = "slide_02.jpg",
                UpperCapt = "work hard",
                BottomCapt = "Dream Big",
                ButtonTitle = "Get Started"
            },
            new Slider
            {
                SliderId = 1,
                Photo = "slide_03.jpg",
                UpperCapt = "work hard",
                BottomCapt = "Dream Big",
                ButtonTitle = "Get Started"
            }
        } ;

        public static List<Iconbox> Iconboxes = new List<Iconbox>()
        {
            new Iconbox
            {
                Id = 1,
                IconName = "desktop",
                Heading = "Responsive Design",
                Content = "Vestibulum non diam quis nisl dignissim posuere a vulputate urna nunc velit"
            },
            new Iconbox
            {
                Id = 2,
                IconName = "diamond",
                Heading = "Very Easy Customizie",
                Content = "Etiam mollis dui diam, eget accumsan neque consectetur quis"
            },
            new Iconbox
            {
                Id = 3,
                IconName = "bullhorn",
                Heading = "Free Font Icons",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam convallis"
            },
            new Iconbox
            {
                Id = 4,
                IconName = "desktop",
                Heading = "Responsive Design",
                Content = "Vestibulum non diam quis nisl dignissim posuere a vulputate urna nunc velit"
            },
            new Iconbox
            {
                Id = 5,
                IconName = "diamond",
                Heading = "Very Easy Customizie",
                Content = "Etiam mollis dui diam, eget accumsan neque consectetur quis"
            },
            new Iconbox
            {
                Id = 6,
                IconName = "bullhorn",
                Heading = "Free Font Icons",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam convallis"
            },
        };

        public static List<Workers> ShownWorkers = new List<Workers>()
        {
            new Workers
            {
                Image = "user_06.jpg",
                Uppercont = "PETER HART",
                Bottomcont = "Creative Director"
            },
            new Workers
            {
                Image = "user_07.jpg",
                Uppercont = "BETTY LANE",
                Bottomcont = "Marketing Manager"
            },
            new Workers
            {
                Image = "user_08.jpg",
                Uppercont = "PETER HART",
                Bottomcont = "Creative Director"
            },
            new Workers
            {
                Image = "user_09.jpg",
                Uppercont = "PETER HART",
                Bottomcont = "Creative Director"
            },

        };

        public static List<Writings> Writings = new List<Writings>()
        {
            new Writings
            {
                UpperCont = "We are Bemax",
                BottomCont = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Sed quis neque rutrum, dignissim libero vitae, ullamcorper diam. Donec eros massa, cursus eu risus nec, tempus aliquam odio. Proin lacinia urna ac ex"
            },
            new Writings
            {
                UpperCont = "What We Do?",
                BottomCont = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Sed quis neque rutrum, dignissim libero vitae, ullamcorper diam. Donec eros massa, cursus eu risus nec, tempus aliquam odio. Proin lacinia urna ac ex"
            },
            new Writings
            {
                UpperCont = "Why Choose Us?",
                BottomCont = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Sed quis neque rutrum, dignissim libero vitae, ullamcorper diam. Donec eros massa, cursus eu risus nec, tempus aliquam odio. Proin lacinia urna ac ex"
            },
        };

      
    }
}