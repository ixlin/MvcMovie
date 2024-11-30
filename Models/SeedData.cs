using System;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using NuGet.Common;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider){
        using (var context=new MvcMovieContext(serviceProvider.GetRequiredService<
        DbContextOptions<MvcMovieContext>>())){
            /**
             * 如果数据库中Movie表中有任一数据记录，则不再执行初始化数据操作
            **/
            if(context.Movie.Any())
            {
                return;
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "肖申克的救赎",
                    ReleaseDate = DateTime.Parse("1994-09-10"),
                    Genre = "犯罪",
                    Price = 14.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "霸王别姬",
                    ReleaseDate = DateTime.Parse("1993-07-26"),
                    Genre = "剧情",
                    Price = 9.99M,
                    Rating= "R"
                },
                new Movie
                {
                    Title = "泰坦尼克号",
                    ReleaseDate = DateTime.Parse("1997-04-03"),
                    Genre = "剧情",
                    Price = 12.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "阿甘正传",
                    ReleaseDate = DateTime.Parse("1994-06-23"),
                    Genre = "剧情",
                    Price = 10.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "千与千寻",
                    ReleaseDate = DateTime.Parse("1991-05-26"),
                    Genre = "动画",
                    Price = 8.99M,
                    Rating = "G"
                },
                new Movie
                {
                    Title = "盗梦空间",
                    ReleaseDate = DateTime.Parse("2003-06-12"),
                    Genre = "剧情",
                    Price = 12.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "海上钢琴师",
                    ReleaseDate = DateTime.Parse("2006-06-12"),
                    Genre = "喜剧",
                    Price = 10.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "这个杀手不太冷",
                    ReleaseDate = DateTime.Parse("2010-06-12"), Genre = "动作", Price = 10.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "龙猫", ReleaseDate = DateTime.Parse("2007-06-12"),
                    Genre = "动画", Price = 0.99M, Rating = "G"
                }
            );
            context.SaveChanges();
        }
    }
}
