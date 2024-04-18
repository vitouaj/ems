<template>
  <div>
    <form v-if="mode === 'login'" @submit.prevent="login">
      <input type="email" v-model="loginData.email" placeholder="Email" required>
      <input type="password" v-model="loginData.password" placeholder="Password" required>
      <button type="submit">Log In</button>
    </form>
    

    <form v-else @submit.prevent="signup">
      <input type="text" v-model="signupData.name" placeholder="Name" required>
      <input type="email" v-model="signupData.email" placeholder="Email" required>
      <input type="password" v-model="signupData.password" placeholder="Password" required>
      <button type="submit">Sign Up</button>
    </form>
    <p>
      <button @click="toggleMode">{{ mode === 'login' ? 'Sign Up' : 'Log In' }}</button>
    </p>
  </div>
</template>

<script setup lang="ts">
import { ref } from 'vue';

const mode = ref('login'); // Default mode is login
const loginData = ref({
  email: '',
  password: ''
});
const signupData = ref({
  name: '',
  email: '',
  password: ''
});

const login = () => {
};

const signup = () => {
};

const toggleMode = () => {

};
</script>

<style scoped>
/* Your component styles */
</style>
