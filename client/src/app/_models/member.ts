import { Photo } from "./photo"


 
export interface Member {
  
    id: number
    userName: string
    url: any
    Age: number
    knownAs: any
    createAt: string
    lastActive: string
    gender: string
    introduction: string
    lookingFor: string
    interests: string
    country: string
    city: string
    Photos: Photo[]
  }
 