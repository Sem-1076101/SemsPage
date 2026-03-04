export interface Project {
  id: number
  title: string
  description: string
  tags: string[]
  githubUrl?: string
  liveUrl?: string
}

export interface Experience {
  id: number
  title: string
  organization: string
  period: string
  description: string
  type: 'work' | 'education'
}

export interface Skill {
  name: string
  category: 'Frontend' | 'Backend' | 'Tools'
}
