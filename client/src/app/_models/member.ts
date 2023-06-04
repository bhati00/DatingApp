import { Photo } from "./photo"


 
export interface Member {
    id: number
    userName: string
    photoUrl: any
    age: number
    knowAs: any
    createAt: string
    lastActive: string
    gender: string
    introduction: string
    lookingFor: string
    interests: string
    country: string
    city: string
    photos: Photo[]
  }
 