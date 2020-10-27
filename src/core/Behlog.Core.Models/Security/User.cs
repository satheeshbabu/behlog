﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Behlog.Core.Models.Enum;
using Behlog.Core.Models.Content;
using Behlog.Core.Models.System;

namespace Behlog.Core.Models.Security {

    public class User : IdentityUser<Guid> {
        public User() {
            Claims = new HashSet<UserClaim>();
            Tokens = new HashSet<UserToken>();
            CreatedPosts = new HashSet<Post>();
            ModifiedPosts = new HashSet<Post>();
            Comments = new HashSet<Comment>();
            ModifiedComments = new HashSet<Comment>();
            Likes = new HashSet<PostLike>();
            Websites = new HashSet<Website>();
            Logins = new HashSet<UserLogin>();
        }

        #region Properties
        public string Title { get; set; }
        public UserStatus Status { get; set; }
        public string WebUrl { get; set; }
        public string Phone { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Description { get; set; }
        #endregion

        #region Navigations
        public ICollection<UserClaim> Claims { get; set; }
        public ICollection<UserToken> Tokens { get; set; }
        public ICollection<UserRole> Roles { get; set; }
        public ICollection<Post> CreatedPosts { get; set; }
        public ICollection<Post> ModifiedPosts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Comment> ModifiedComments { get; set; }
        public ICollection<PostLike> Likes { get; set; }
        public ICollection<Website> Websites { get; set; }
        public ICollection<UserLogin> Logins { get; set; }
        public ICollection<UserMeta> Meta { get; set; }
        #endregion

    }
}