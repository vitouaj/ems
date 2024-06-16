<template>
  <div>
    <v-row>
      <v-col cols="12" class="d-flex align-start">
        <div>
          <h2 class="font-weight-bold text-uppercase">RUPP Business Class Meeting</h2>
          <p class="text-caption">by: RUPP group</p>
        </div>
        <div class="pt-1">
          <v-chip class="rounded-lg mx-1" size="x-small" variant="elevated" color="#7CB518">
            <v-icon size="small">mdi-alarm</v-icon><span>start at {{ e_Time }}</span>
          </v-chip>
          <v-chip class="rounded-lg mx-1" size="x-small" variant="elevated" color="#FF7F00">
            <p>{{ e_tag }}</p>
          </v-chip>
        </div>
      </v-col>
      <v-col cols="12">
        <v-row>
          <v-col cols="4">
            <v-img
              src="https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgyPOjxjl0l0xUIdDF8JbrVgPN8W4Wh79jpEy1YQYAtagSfZKVuwKkpJRQcFvNIiy36lgwMn56dN4oBdNqmsxHzKZzdXm630fkiNwnSzwpsds_uetpWB6jAsCGSuAqUEFooGPftVy387jM/s1600/rupp.jpg"
              width="100%"
              class="rounded-lg"
              cover
              :aspect-ratio="1"
            />
          </v-col>
          <v-col cols="4">
            <v-img
              class="rounded-lg"
              src="https://www.rupp.edu.kh/ifl/english/image_banner/img_ifl_doe.jpg"
              :aspect-ratio="1"
              width="100%"
              cover
            />
          </v-col>
          <v-col cols="4">
            <v-row>
              <v-col cols="12">
                <v-img
                  src="https://www.researchgate.net/publication/335101723/figure/fig1/AS:790482535870464@1565477131379/Royal-University-of-Phnom-Penhs-main-building-Building-A.jpg"
                  max-width="190"
                  class="rounded-lg"
                />
              </v-col>
              <v-col cols="12">
                <v-img
                  src="https://www.researchgate.net/publication/335101723/figure/fig1/AS:790482535870464@1565477131379/Royal-University-of-Phnom-Penhs-main-building-Building-A.jpg"
                  max-width="190"
                  class="rounded-lg"
                />
              </v-col>
            </v-row>
          </v-col>
          <v-col cols="12" class="d-flex justify-center">
            <v-card
              min-width="110"
              class="mx-2 pa-2 d-flex align-center flex-column smallDetailBox"
            >
              <v-icon size="x-large" color="#004B8D"> mdi-account-group-outline </v-icon>
              <p>Participator</p>
              <p>23/50</p>
            </v-card>
            <v-card
              min-width="110"
              class="mx-2 pa-2 d-flex flex-column align-center smallDetailBox"
            >
              <v-icon size="x-large" color="#004B8D"> mdi-glasses </v-icon>
              <p>viewers</p>
              <p>1,020</p>
            </v-card>
            <v-card
              min-width="110"
              class="mx-2 pa-2 d-flex flex-column align-center smallDetailBox"
            >
              <v-icon size="x-large" color="#004B8D"> mdi-clipboard-text-outline </v-icon>
              <p>Session</p>
              <p><v-btn variant="text" text="view"></v-btn></p>
            </v-card>
          </v-col>
          <v-col cols="12">
            <h3 class="font-weight-bold">Description</h3>
            <p>
              Lorem ipsum dolor sit amet consectetur adipisicing elit. Animi provident laboriosam
              dicta beatae eaque explicabo veritatis sapiente, tempore sed maiores, quod dolores
              similique mollitia officia exercitationem sint eos, neque recusandae! Ut, nesciunt
              vitae eius nemo itaque et eos. Nemo corporis hic dolorem quibusdam, mollitia rem quasi
              praesentium officia ad vel provident accusantium aliquam iure itaque reiciendis
              quaerat sint in corrupti!
            </p>
          </v-col>
          <v-col cols="6">
            <v-row>
              <v-col cols="12" class="d-flex">
                <p><span class="font-weight-bold">Start Date: </span>12 Dec 2024</p>
              </v-col>
              <v-col cols="12">
                <p><span class="font-weight-bold">End Date: </span>15 Dec 2024</p>
              </v-col>
              <v-col cols="12">
                <p><span class="font-weight-bold">Time: </span>8:30 AM</p>
              </v-col>
              <v-col cols="12">
                <p>
                  <span class="font-weight-bold">Map: </span>Russian Federation Blvd (110), Phnom
                  Penh 120404
                </p>
              </v-col>
            </v-row>
          </v-col>
          <v-col cols="6">
            <iframe
              src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d62534.89697091127!2d104.82653816787605!3d11.592585684062556!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3109519fe4077d69%3A0x20138e822e434660!2sRoyal%20University%20of%20Phnom%20Penh!5e0!3m2!1sen!2skh!4v1715510130198!5m2!1sen!2skh"
              width="100%"
              height="200"
              style="border: 0"
              allowfullscreen=""
              loading="lazy"
              referrerpolicy="no-referrer-when-downgrade"
            >
            </iframe>
          </v-col>
          <v-col cols="12" class="d-flex justify-end">
            <v-btn class="mx-2" color="#004B8D">
              <v-icon> mdi-delete </v-icon>
              Delete
            </v-btn>
            <v-btn color="#FF7F00">
              <v-icon> mdi-pen </v-icon>
              Edit
            </v-btn>
          </v-col>
        </v-row>
      </v-col>
    </v-row>
  </div>
</template>
<script>
export default {
  data() {
    return {
      e_Time: '8.30',
      e_Title: 'Event Name sample',
      e_location: 'event_location',
      e_participate: 55,
      e_tag: 'education'
    }
  }
}
</script>

<style>
.smallDetailBox {
  border: 1px solid rgba(255, 127, 0, 0.2);
  box-shadow: 2px 5px 1px rgba(255, 127, 0, 0.2);
}
</style>
