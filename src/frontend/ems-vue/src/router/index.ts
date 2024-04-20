import { createRouter, createWebHistory } from 'vue-router'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: () => import('../views/LandingPageView.vue')
    },
    {
      path: '/authUser',
      name: 'authUser',
      component: () => import('../AuthForm/User/AuthUserScreen.vue')
    },
    {
      path: '/authAdmin',
      name: 'authAdmin',
      component: () => import('../AuthForm/Admin/AuthAdminScreen.vue')
    },

    // {
    //   path: '/about',
    //   name: 'about',
    //   // route level code-splitting
    //   // this generates a separate chunk (About.[hash].js) for this route
    //   // which is lazy-loaded when the route is visited.
    //   component: () => import('../views/AboutView.vue')
    // }
  ]
})

export default router
