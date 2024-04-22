import { createRouter, createWebHistory } from 'vue-router'

const routes = [
  {
    path: '/',
    name: 'home',
    component: () => import('../views/LandingPageView.vue')
  },
  {
    path: '/authUser/:mode',
    name: 'authUser',
    component: () => import('../AuthForm/User/AuthUserScreen.vue')
  },
  {
    path: '/authAdmin',
    name: 'authAdmin',
    component: () => import('../AuthForm/Admin/AuthAdminScreen.vue')
  },
]

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes
})

export default router


