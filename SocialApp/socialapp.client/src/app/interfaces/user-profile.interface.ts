import { Post } from "./post.interface";

export interface UserProfile {
  name: string;
  email: string;
  phone: string;
  profilePicture: string;
  posts: Post[];
}