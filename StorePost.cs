﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace guestbook
{
    internal class StorePost
    {
        private string json = @"storepost.json";
        private List<Post> posts = new List<Post>();

        // Check if there is a JSON file, if true, read it's content.
        public StorePost()
        {
            if (File.Exists(@"storepost.json") == true)
            {
                string jsonString = File.ReadAllText(json);
                posts = JsonSerializer.Deserialize<List<Post>>(jsonString);
            }
        }

        // Add post to guestbook, write it's contents to file.
        public Post addPost(Post post)
        {
            posts.Add(post);
            toFile();
            return post;
        }


        // Get all posts from json file.
        public List<Post> getPosts()
        {
            return posts;
        }

        // Delete posts and modify the file
        public int delPost(int index)
        {
            posts.RemoveAt(index);
            //save to file;
            toFile();
            return index;
            
        }

        // This method was auto-generated by 'tip' from C#
        private void toFile()
        {
            // let couldn't be used here - why?
            var jsonString = JsonSerializer.Serialize(posts);
            File.WriteAllText(json, jsonString);
        }
    }
}
