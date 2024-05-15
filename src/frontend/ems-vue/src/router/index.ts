import { createRouter, createWebHistory } from 'vue-router';
import AppLayout from '../views/Layouts/AppLayout.vue';

const routes = [
  {
    path: '/authUser/:mode',
    name: 'authUser',
    component: () => import('../AuthForm/User/AuthUserScreen.vue')
  },
  {
    path: '/authAdmin/:mode',
    name: 'authAdmin',
    component: () => import('../AuthForm/Admin/AuthAdminScreen.vue')
  },
  {
    path: '/',
    name: 'home',
    component: AppLayout
  },
  {
    path: '/admin',
    name: 'about',
    component: AppLayout,
    children: [
      {
        path: 'dashboard',
        component: () => import('../views/AdminSite/dashboardView.vue')
      },
      {
        path: 'create-event',
        component: () => import('../views/AdminSite/CreateEvent.vue')
      },
      {
        path: 'all-events',
        component: () => import('../views/AdminSite/AllEvents.vue')
      },
      {
        path: 'detail-screen',
        component: () => import('../views/AdminSite/DetailScreen.vue')
      }
    ]
  },
  {
    path: '/landing',
    name: 'landing',
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
];

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes
});

export default router;
